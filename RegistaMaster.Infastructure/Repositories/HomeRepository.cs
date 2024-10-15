using RegistaMaster.Application.Repositories;
using RegistaMaster.Domain.DTOModels.ChartModels;
using RegistaMaster.Domain.DTOModels.Entities.ActionModels;
using RegistaMaster.Domain.DTOModels.SecurityModels;
using RegistaMaster.Domain.Entities;
using RegistaMaster.Domain.Enums;
using RegistaMaster.Persistance.RegistaMasterContextes;
using Action = RegistaMaster.Domain.Entities.Action;

namespace RegistaMaster.Infastructure.Repositories
{
  public class HomeRepository(IUnitOfWork unitOfWork, SessionDTO session, RegistaMasterContext context) : BaseRepository(session, context), IHomeRepository
  {
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly SessionDTO _session = session;
    private RegistaMasterContext _context = context;

    public async Task<ChartDTO> AdminChart()
    {
      try
      {
        var chart = new ChartDTO();
        var requests = GetNonDeltedAndActive<Request>(t => true);

        chart.RequestOpen = requests.Where(t => t.RequestStatus == RequestStatus.Open).Count();
        chart.RequestStart = requests.Where(t => t.RequestStatus == RequestStatus.Start).Count();
        chart.RequestClosed = requests.Where(t => t.RequestStatus == RequestStatus.Closed).Count();
        chart.RequestWaiting = requests.Where(t => t.RequestStatus == RequestStatus.Waiting).Count();

        var actions = GetQueryable<Action>(t => t.ObjectStatus == ObjectStatus.NonDeleted);

        chart.ActionNotStarted = actions.Where(t => t.ActionStatus == ActionStatus.notStarted).Count();
        chart.ActionContinued = actions.Where(t => t.ActionStatus == ActionStatus.Contiuned).Count();
        chart.ActionCompleted = actions.Where(t => t.ActionStatus == ActionStatus.Completed).Count();
        chart.ActionCancel = actions.Where(t => t.ActionStatus == ActionStatus.Cancel).Count();
        return chart;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<List<UserChartDTO>> AdminChartUserActions()
    {
      try
      {
        var actions = GetQueryable<Action>(t => t.ObjectStatus == ObjectStatus.NonDeleted);
        var users = GetNonDeltedAndActive<User>(t => t.AuthorizationStatus != AuthorizationStatus.Admin).Select(s => new UserChartDTO()
        {
          NotStarted = actions.Where(t => t.ActionStatus == ActionStatus.notStarted && t.ResponsibleId == s.Id).Count(),
          Continued = actions.Where(t => t.ActionStatus == ActionStatus.Contiuned && t.ResponsibleId == s.Id).Count(),
          Completed = actions.Where(t => t.ActionStatus == ActionStatus.Completed && t.ResponsibleId == s.Id).Count(),
          Cancel = actions.Where(t => t.ActionStatus == ActionStatus.Cancel && t.ResponsibleId == s.Id).Count(),
          UserFullName = s.FullName
        }).ToList();
        return users;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<UserChartDTO> DeveloperChart(int id)
    {
      try
      {
        var userActions = GetQueryable<Action>(t => t.ObjectStatus == ObjectStatus.NonDeleted && t.ResponsibleId == id);
        var user = new UserChartDTO()
        {
          NotStarted = userActions.Where(t => t.ActionStatus == ActionStatus.notStarted).Count(),
          Continued = userActions.Where(t => t.ActionStatus == ActionStatus.Contiuned).Count(),
          Completed = userActions.Where(t => t.ActionStatus == ActionStatus.Completed).Count(),
          Cancel = userActions.Where(t => t.ActionStatus == ActionStatus.Cancel).Count(),
        };
        return user;
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public async Task<List<ActionDTO>> GetActionDTOHome()
    {
      try
      {
        var model = GetQueryable<Action>(t => (t.ResponsibleId == _session.Id || t.CreatedBy == _session.Id) && t.ObjectStatus == ObjectStatus.NonDeleted).Select(s => new ActionDTO()
        {
          Id = s.Id,
          Description = s.Description,
          EndDate = s.EndDate,
          OpeningDate = s.OpeningDate,
          ResponsibleId = s.ResponsibleId,
          ActionStatus = s.ActionStatus,
          Subject = s.Subject,
          RequestId = s.RequestId,
          ActionPriorityStatus = s.ActionPriorityStatus,
          LastModifiedBy = s.LastModifiedBy,
          CreatedBy = s.CreatedBy,
          StartDate = s.StartDate,
          CompleteDate = s.CompleteDate,
        }).OrderByDescending(s => s.Id).ToList();
        return model;

      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public async Task<ChartDTO> TeamLeaderChart(int id)
    {
      try
      {
        var chart = new ChartDTO();
        var requests = GetNonDeltedAndActive<Request>(t => t.CreatedBy == id);

        chart.RequestOpen = requests.Where(t => t.RequestStatus == RequestStatus.Open).Count();
        chart.RequestStart = requests.Where(t => t.RequestStatus == RequestStatus.Start).Count();
        chart.RequestClosed = requests.Where(t => t.RequestStatus == RequestStatus.Closed).Count();
        chart.RequestWaiting = requests.Where(t => t.RequestStatus == RequestStatus.Waiting).Count();


        var actions = GetQueryable<Action>(t => t.ObjectStatus == ObjectStatus.NonDeleted && t.CreatedBy == id);

        chart.ActionNotStarted = actions.Where(t => t.ActionStatus == ActionStatus.notStarted).Count();
        chart.ActionContinued = actions.Where(t => t.ActionStatus == ActionStatus.Contiuned).Count();
        chart.ActionCompleted = actions.Where(t => t.ActionStatus == ActionStatus.Completed).Count();
        chart.ActionCancel = actions.Where(t => t.ActionStatus == ActionStatus.Cancel).Count();


        var userAction = GetQueryable<Action>(t => t.ObjectStatus == ObjectStatus.NonDeleted && t.ResponsibleId == id);
        var user = new UserChartDTO()
        {
          NotStarted = userAction.Where(t => t.ActionStatus == ActionStatus.notStarted).Count(),
          Continued = userAction.Where(t => t.ActionStatus == ActionStatus.Contiuned).Count(),
          Completed = userAction.Where(t => t.ActionStatus == ActionStatus.Completed).Count(),
          Cancel = userAction.Where(t => t.ActionStatus == ActionStatus.Cancel).Count()
        };

        chart.UserChartDTO = user;
        return chart;
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }
  }
}
