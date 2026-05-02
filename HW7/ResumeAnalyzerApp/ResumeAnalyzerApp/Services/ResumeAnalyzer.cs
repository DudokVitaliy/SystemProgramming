public static class ResumeAnalyzer
{
    public static Resume MostExperienced(List<Resume> list)
        => list.OrderByDescending(x => x.ExperienceYears).First();

    public static Resume LeastExperienced(List<Resume> list)
        => list.OrderBy(x => x.ExperienceYears).First();

    public static Resume LowestSalary(List<Resume> list)
        => list.OrderBy(x => x.SalaryMin).First();

    public static Resume HighestSalary(List<Resume> list)
        => list.OrderByDescending(x => x.SalaryMax).First();

    public static List<Resume> ByCity(List<Resume> list, string city)
        => list.Where(x => x.City == city).ToList();
}