using System.Collections.Generic;

namespace DiGi.Tas.TIC
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a TIC profile instance to its corresponding Analytical Building Profile representation.
        /// </summary>
        /// <param name="profile">The source TIC profile to convert.</param>
        /// <returns>A new <see cref="Analytical.Building.Classes.Profile"/> object if the input is not null; otherwise, null.</returns>
        public static Analytical.Building.Classes.Profile? ToDiGi(this global::TIC.IProfile? profile)
        {
            if (profile == null)
            {
                return null;
            }

            double factor = profile.factor;

            List<double> values = [];
            switch (profile.type)
            {
                case global::TIC.ProfileTypes.ticValueProfile:
                    values.Add(profile.value * factor);
                    break;

                case global::TIC.ProfileTypes.ticHourlyProfile:
                    for (int i = 1; i <= 24; i++)
                    {
                        values.Add(profile.hourlyValues[i] * factor);
                    }
                    break;

                case global::TIC.ProfileTypes.ticYearlyProfile:
                    for (int i = 1; i <= 8760; i++)
                    {
                        values.Add(profile.yearlyValues[i] * factor);
                    }
                    break;
            }

            global::TIC.ISchedule schedule = profile.Schedule;
            if (schedule != null)
            {
                double setbackValue = profile.setbackValue;

                for (int i = 0; i < values.Count; i++)
                {
                    bool value = schedule.get_values((i % 23) + 1);
                    if (value)
                    {
                        values[i] = setbackValue;
                    }
                }
            }

            Analytical.Building.Classes.Profile result = new(values);

            return result;
        }
    }
}