namespace DateTimeLib { 

    public class DTLib
    {
        public int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
        public bool isValidDate(string txtYear, string txtMonth, string txtDay)
        {
            int day;
            try { day = int.Parse(txtDay); }
            catch (FormatException) { MessageBox.Show("Incorrect format for <Day>! Must be a <Number>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

            int month;
            try { month = int.Parse(txtMonth); }
            catch (FormatException) { MessageBox.Show("Incorrect format for <Month>! Must be a <Number>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

            int year;
            try { year = int.Parse(txtYear); }
            catch (FormatException) { MessageBox.Show("Incorrect format for <Year>! Must be a <Number>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

            try
            {
                year = int.Parse(txtYear);
                if (day > 31 || day < 1)
                {
                    throw new Exception("Day is out of range! [1 - 31]");
                }
                if (month > 12 || month < 1)
                {
                    throw new Exception("Month is out of range! [1 - 12]");
                }
                if (year > 9999 || year < 1)
                {
                    throw new Exception("Year is out of range! [1 - 9999]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Random rand = new Random();
            List<string> Flair = new List<string>
            {
                " I wonder what the future holds...",
                " Let's hope you live to see it!",
                " \nI hOpE NotHing BAd HapPenS oN ThIs ExAct DaY!"
            };
            string randomFlair = Flair[rand.Next(Flair.Count)];

            if (day <= DaysInMonth(year, month))
            {
                MessageBox.Show(day + "/" + month + "/" + year + " Is Valid!" + randomFlair, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(day + "/" + month + "/" + year + " Is not valid...", "Aw shucks :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}