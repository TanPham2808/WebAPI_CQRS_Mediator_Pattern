using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesDetailQuery, LeaveTypeDetailDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypesDetailQuery request, CancellationToken cancellationToken)
        {
            // Query theo Id
            var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

            if (leaveType == null)
            {
                throw new NotfoundException(nameof(LeaveType), request.Id);
            }

            // Convert data object to DTO object
            var data = _mapper.Map<LeaveTypeDetailDto>(leaveType);

            return data;
        }
    }
}
