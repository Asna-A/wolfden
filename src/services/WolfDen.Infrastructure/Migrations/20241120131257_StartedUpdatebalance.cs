﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WolfDen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StartedUpdatebalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                schema: "wolfden",
                table: "LeaveType",
                newName: "LeaveCategoryId")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "IncrementGap",
                schema: "wolfden",
                table: "LeaveType",
                newName: "IncrementGapId")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "DaysChekcMore",
                schema: "wolfden",
                table: "LeaveType",
                newName: "DaysCheckMore")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "LeaveRequestStatus",
                schema: "wolfden",
                table: "LeaveRequest",
                newName: "LeaveRequestStatusId")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<string>(
                name: "LOPDays",
                schema: "wolfden",
                table: "LOP",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LOP")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "LOP")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<int>(
                name: "LOPDaysCount",
                schema: "wolfden",
                table: "LOP",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LOP")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<bool>(
                name: "HalfDay",
                schema: "wolfden",
                table: "LeaveRequest",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LOPDaysCount",
                schema: "wolfden",
                table: "LOP")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LOP")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "LeaveCategoryId",
                schema: "wolfden",
                table: "LeaveType",
                newName: "Type")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "IncrementGapId",
                schema: "wolfden",
                table: "LeaveType",
                newName: "IncrementGap")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "DaysCheckMore",
                schema: "wolfden",
                table: "LeaveType",
                newName: "DaysChekcMore")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveType")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.RenameColumn(
                name: "LeaveRequestStatusId",
                schema: "wolfden",
                table: "LeaveRequest",
                newName: "LeaveRequestStatus")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "LOPDays",
                schema: "wolfden",
                table: "LOP",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LOP")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "LOP")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<bool>(
                name: "HalfDay",
                schema: "wolfden",
                table: "LeaveRequest",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "LeaveRequest")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "wolfdenHT")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }
    }
}
