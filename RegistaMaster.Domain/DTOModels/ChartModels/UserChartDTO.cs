namespace RegistaMaster.Domain.DTOModels.ChartModels;

public class UserChartDTO
{
  public string UserFullName { get; set; }
  public int NotStarted { get; set; }
  public int Continued { get; set; }
  public int Completed { get; set; }
  public int Cancel { get; set; }
}
