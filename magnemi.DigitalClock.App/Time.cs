using System;
using System.Timers;

namespace magnemi.DigitalClock.App
{
    public class Time
    {
        private int _hours = -99;
        private int _minutes = -99;
        private int _seconds = -99;
        private String _meridian = null;

        public Time(String givenTime)
        {
            String[] givenTimeSplit = givenTime.Split(new Char[] { ' ', ':' });

            addZeroToBeginningOfTime(givenTime);

            set_hours(givenTimeSplit[0]);
            set_minutes(givenTimeSplit[1]);
            set_seconds(givenTimeSplit[2]);
            set_meridian(givenTimeSplit[3]);


            tickClock();
        }

        public String addZeroToBeginningOfTime(String givenTime)
        {
            if (givenTime.Length == 10)
            {
                return '0' + givenTime;
            }
            return givenTime;
        }

        public bool set_hours(String a)
        {
            if (Convert.ToInt32(a) != -99 && Convert.ToInt32(a) > 00)
            {
                _hours = Convert.ToInt32(a);
                return true;
            }
            return false;
        }

        public String get_hours()
        {
            if (_hours != -99)
            {
                return _hours.ToString();
            }
            return "Error";
        }

        public bool set_minutes(String a)
        {
            if (Convert.ToInt32(a) != -99 && Convert.ToInt32(a) >= 00)
            {

                _minutes = Convert.ToInt32(a);
                return true;
            }
            return false;
        }

        public String get_minutes()
        {
            if (_minutes != -99)
            {
                if (_minutes.ToString().Length == 1)
                {
                    return '0' + _minutes.ToString();
                }

                return _minutes.ToString();
            }
            return "Error";
        }

        public bool set_seconds(String a)
        {
            if (Convert.ToInt32(a) != -99 && Convert.ToInt32(a) >= 00)
            {
                _seconds = Convert.ToInt32(a);
                return true;
            }
            return false;
        }

        public String get_seconds()
        {
            if (_seconds != -99)
            {
                if (_seconds.ToString().Length == 1)
                {
                    return '0' + _seconds.ToString();
                }

                return _seconds.ToString();
            }
            return "Error";
        }

        public bool set_meridian(String a)
        {
            if (a.Trim() == "" && _hours == 12 && _minutes == 00 && _seconds == 00)
            {
                _meridian = "";
                return true;
            }
            else if (a.ToUpper() == "AM")
            {
                _meridian = a;
                return true;
            }
            else if (a.ToUpper() == "PM")
            {
                _meridian = a;
                return true;
            }
            return false;
        }


        public String get_meridian()
        {
            if (_meridian != null)
            {
                return _meridian.ToString();
            }
            return "Error";
        }

        public String toggleMeridian()
        {
            if (_meridian == "AM")
            {
                return "PM";
            }
            return "AM";
        }

        public String showTime()
        {

            return get_hours() + ":" + get_minutes() + ":" + get_seconds() + " " + get_meridian();
        }

        public void tickClock()
        {
            if (_hours == 11 && _minutes == 59 && _seconds == 59)
            {
                set_meridian(toggleMeridian());
            }

            if (_hours == 12 && _minutes == 59 && _seconds == 59)
            {
                addSecond();
                set_minutes("00");
                set_seconds("00");
            }
            else if (_seconds < 59)
            {
                set_seconds((_seconds + 1).ToString());
            }
            else if (_minutes == 59 && _seconds == 59)
            {
                addHour();
                set_minutes("00");
                set_seconds("00");
            }
            else if (_seconds == 59)
            {
                addMinute();
                set_seconds("00");
            }
        }

        public bool addSecond()
        {
            set_seconds((_seconds + 1).ToString());
            return true;
        }

        public bool addMinute()
        {
            set_minutes((_minutes + 1).ToString());
            return true;
        }

        public bool addHour()
        {
            set_hours((_hours + 1).ToString());
            return true;
        }
    }
}
