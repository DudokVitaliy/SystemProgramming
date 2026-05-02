using System.Globalization;
using System.IO;

public static class ResumeParser
{
    public static Resume Parse(string path)
    {
        var lines = File.ReadAllLines(path);

        return new Resume
        {
            Name = lines[0].Split(':')[1].Trim(),
            City = lines[1].Split(':')[1].Trim(),
            ExperienceYears = int.Parse(lines[2].Split(':')[1]),
            SalaryMin = decimal.Parse(lines[3].Split(':')[1], CultureInfo.InvariantCulture),
            SalaryMax = decimal.Parse(lines[4].Split(':')[1], CultureInfo.InvariantCulture)
        };
    }
}