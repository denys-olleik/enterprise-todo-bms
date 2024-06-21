﻿namespace EnterpriseToDo.Models.InvoiceViewModels
{
  public class InvoiceLineViewModel
  {
    public int ID { get; set; }

    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool TitleOrDescriptionModified { get; set; }

    public decimal? Quantity { get; set; }
    public decimal? Price { get; set; }
    public bool QuantityOrPriceModified { get; set; }

    public int RevenueChartOfAccountId { get; set; }
    public int AssetsChartOfAccountId { get; set; }
  }
}