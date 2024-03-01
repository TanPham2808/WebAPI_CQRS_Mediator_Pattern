using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    //public class GetLeaveTypesDetailQuery
    //{
    //}

    public record GetLeaveTypesDetailQuery(int Id) : IRequest<LeaveTypeDetailDto>;
}
