using RegistaMaster.Domain.DTOModels.ChartModels;
using RegistaMaster.Domain.DTOModels.Entities.ActionModels;

namespace RegistaMaster.Application.Repositories
{
  public interface IHomeRepository : IBaseRepository
  {
    Task<List<ActionDTO>> GetActionDTOHome();
    Task<ChartDTO> AdminChart();
    Task<List<UserChartDTO>> AdminChartUserActions();
    Task<ChartDTO> TeamLeaderChart(int id);
    Task<UserChartDTO> DeveloperChart(int id);
  }
}
