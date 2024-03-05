using HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.LeaveManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<LeaveTypeController>
        [HttpGet]
        public async Task<List<LeaveTypeDto>> Get()
        {
            var leaveTypes = await _mediator.Send(new GetLeaveTypesQuery());
            return leaveTypes;
        }

        // GET api/<LeaveTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDetailDto>> Get(int id)
        {
            var leaveType = await _mediator.Send(new GetLeaveTypesDetailQuery(id));
            return Ok(leaveType);
        }

        // POST api/<LeaveTypeController>
        [HttpPost]
        public async Task<ActionResult> Post(CreateLeaveTypeCommand leaveType)
        {
            var response = await _mediator.Send(leaveType);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<LeaveTypeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(UpdateLeaveTypeCommand request)
        {
            await _mediator.Send(request);
            return NoContent();
        }

        // DELETE api/<LeaveTypeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveTypeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
