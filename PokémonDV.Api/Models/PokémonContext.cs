using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace PokémonDV.Api.Models
{
    public class PokémonContext : DbContext
    {
        public PokémonContext(DbContextOptions<PokémonContext> options) : base(options)
        {

        }

        public DbSet<BaseStatSet> BaseStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BaseStatSet>(entity =>
            {
                entity.ToTable("BaseStats");
                entity.HasKey(x => x.PokédexId);
            });
        }

        private static List<BaseStatSet> GetBaseStats()
        {
            string filePath = "Resources/BaseStats.xlsx";
            FileStream fileStream = File.OpenRead(filePath);
            ExcelPackage excelPackage = new();
            excelPackage.Load(fileStream);
            var worksheet = excelPackage.Workbook.Worksheets["Sheet1"];

            DataTable excelasTable = new();
            foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                if (!string.IsNullOrEmpty(firstRowCell.Text))
                    excelasTable.Columns.Add(firstRowCell.Text);
            }

            int startRow = 2;

            for (int rowNum = startRow; rowNum <= worksheet.Dimension.End.Row; rowNum++)
            {
                var wsRow = worksheet.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
                DataRow row = excelasTable.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }

            var generatedType = JsonConvert.DeserializeObject<List<BaseStatSet>>(JsonConvert.SerializeObject(excelasTable));
            return (List<BaseStatSet>)Convert.ChangeType(generatedType, typeof(List<BaseStatSet>));
        }
    }
}
