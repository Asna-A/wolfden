﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using WolfDen.Application.DTOs.Attendence;
using WolfDen.Application.Requests.Commands.Attendence.CloseAttendance;
using WolfDen.Application.Requests.DTOs.Attendence;
using WolfDen.Application.Requests.Queries.Attendence.AllEmployeesMonthlyReport;
using WolfDen.Application.Requests.Queries.Attendence.AttendanceHistory;
using WolfDen.Application.Requests.Queries.Attendence.AttendanceSummary;
using WolfDen.Application.Requests.Queries.Attendence.CheckAttendanceClose;
using WolfDen.Application.Requests.Queries.Attendence.DailyAttendanceReport;
using WolfDen.Application.Requests.Queries.Attendence.DailyStatus;
using WolfDen.Application.Requests.Queries.Attendence.MonthlyAttendanceReport;
using WolfDen.Application.Requests.Queries.Attendence.WeeklySummary;

namespace WolfDen.API.Controllers.Attendence
{
    [Route("api/attendance")]
    [ApiController]
    public class Attendance : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly PdfService _pdfService;
        public Attendance(IMediator mediator, PdfService pdfService)
        {
            _mediator = mediator;
            _pdfService = pdfService;
        }

        [HttpGet("daily-attendance")]
        public async Task<IActionResult> GetAttendenceLog([FromQuery] DailyDetails DailyDetails, CancellationToken cancellationToken)
        {
            DailyAttendanceDTO attendance = await _mediator.Send(DailyDetails, cancellationToken);
            return Ok(attendance);
        }

        [HttpGet("daily-attendance-pdf")]
        public async Task<IResult> GeneratePdf([FromQuery] DailyDetailsPdf DailyDetailspdf, CancellationToken cancellationToken)
        {
            DailyAttendanceDTO attendenceList = await _mediator.Send(DailyDetailspdf, cancellationToken);
            var document = _pdfService.CreateDocument(attendenceList);
            var pdf = document.GeneratePdf();
            return Results.File(pdf, "application/pdf", "DailyReport.pdf");
        }

        [HttpGet("employee/monthly")]
        public async Task<AttendanceSummaryDTO> GetMonthlyAttendance([FromQuery] AttendanceSummaryQuery query, CancellationToken cancellationToken)
        {
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpGet("employee/daily")]
        public async Task<List<DailyStatusDTO>> GetDailyStatus([FromQuery] DailyStatusQuery query, CancellationToken cancellationToken)
        {
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpGet("employee/weekly")]
        public async Task<List<WeeklySummaryDTO>> GetWeeklySummary([FromQuery] WeeklySummaryQuery query, CancellationToken cancellationToken)
        {
            return await _mediator.Send(query, cancellationToken);
        }
        [HttpGet("monthly-report")]
        public async Task<IActionResult> GenerateMonthlyReport([FromQuery] MonthlyReportQuery MonthlyReportQuery, CancellationToken cancellationToken)
        {
            MonthlyReportDTO monthlyReport = await _mediator.Send(MonthlyReportQuery, cancellationToken);
            return Ok(monthlyReport);
        }

        [HttpPost("close-attendance")]
        public async Task<IActionResult> CloseAttendance([FromQuery] CloseAttendanceCommand closeAttendanceCommand, CancellationToken cancellationToken)
        {
            int closeAttendance = await _mediator.Send(closeAttendanceCommand, cancellationToken);
            return Ok(closeAttendance);
        }

        [HttpGet("all-employees-monthly-report")]
        public async Task<IActionResult> AllEmployeeMonthlyReport([FromQuery] AllEmployeesMonthlyReportQuery employeesMonthlyReportQuery, CancellationToken cancellationToken)
        {
            MonthlyReportAndPageCountDTO monthlyReport = await _mediator.Send(employeesMonthlyReportQuery, cancellationToken);
            return Ok(monthlyReport);
        }

        [HttpGet("check-attendance-close")]
        public async Task<IActionResult> CheckAttendanceClose([FromQuery] CheckAttendanceClosedQuery checkAttendanceClosedQuery, CancellationToken cancellationToken)
        {
            CheckAttendanceClosedDTO isClosed = await _mediator.Send(checkAttendanceClosedQuery, cancellationToken);
            return Ok(isClosed);
        }

        [HttpGet("employee/history")]
        public async Task<AttendanceHistoryDTO> GetHistory([FromQuery] AttendanceHistoryQuery query, CancellationToken cancellationToken)
        {
            return await _mediator.Send(query, cancellationToken);
        }
    }
}


       
 
