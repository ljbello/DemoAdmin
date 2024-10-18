using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplier
{
    public int SupSupplierId { get; set; }

    public string SupName { get; set; } = null!;

    public string? SupPhone { get; set; }

    public string? SupFax { get; set; }

    public string? SupNotes { get; set; }

    public string? SupAddress { get; set; }

    public string? SupCity { get; set; }

    public string? StaStateId { get; set; }

    public string? SupZip { get; set; }

    public string? SupAccountNumber { get; set; }

    public string? SupUrl { get; set; }

    public string? SupAccountingPhone { get; set; }

    public string? SupCode { get; set; }

    public int? SupProductCounter { get; set; }

    public bool SupAutoOrderProcessEnabled { get; set; }

    public bool SupOrderStatusEnabled { get; set; }

    public decimal? SupExpectedDpsalesRatio { get; set; }

    public string? Abbreviation { get; set; }

    public bool Active { get; set; }

    public bool IsDigitalAlliance { get; set; }

    public bool? CanPrintFoil { get; set; }

    public string? ContactEmailCancellation { get; set; }

    public string? ContactEmailOrders { get; set; }

    public string? ContactEmailDelinquent { get; set; }

    public bool SupportsEnvelopeAddressing { get; set; }

    public bool SupportsEnvelopeAddressingStamp { get; set; }

    public bool SupportsMailing { get; set; }

    public virtual ICollection<DeliveryEstimationCategoryElementBySupplier> DeliveryEstimationCategoryElementBySuppliers { get; set; } = new List<DeliveryEstimationCategoryElementBySupplier>();

    public virtual ICollection<DeliveryEstimationSupplierClosure> DeliveryEstimationSupplierClosures { get; set; } = new List<DeliveryEstimationSupplierClosure>();

    public virtual ICollection<DeliveryEstimationSupplierOrderCutOff> DeliveryEstimationSupplierOrderCutOffs { get; set; } = new List<DeliveryEstimationSupplierOrderCutOff>();

    public virtual TblState? StaState { get; set; }

    public virtual ICollection<SupplierAllocationFoilDie> SupplierAllocationFoilDies { get; set; } = new List<SupplierAllocationFoilDie>();

    public virtual ICollection<SupplierCardSizeMapping> SupplierCardSizeMappings { get; set; } = new List<SupplierCardSizeMapping>();

    public virtual ICollection<SupplierConfig> SupplierConfigs { get; set; } = new List<SupplierConfig>();

    public virtual ICollection<SupplierEmailExtractor> SupplierEmailExtractors { get; set; } = new List<SupplierEmailExtractor>();

    public virtual ICollection<SupplierOrderStatusCrossRef> SupplierOrderStatusCrossRefs { get; set; } = new List<SupplierOrderStatusCrossRef>();

    public virtual ICollection<SupplierOrderStatusInvalidPo> SupplierOrderStatusInvalidPos { get; set; } = new List<SupplierOrderStatusInvalidPo>();

    public virtual ICollection<SupplierPaperFinishMapping> SupplierPaperFinishMappings { get; set; } = new List<SupplierPaperFinishMapping>();

    public virtual ICollection<SupplierPaperStockMapping> SupplierPaperStockMappings { get; set; } = new List<SupplierPaperStockMapping>();

    public virtual ICollection<SupplierProductMapping> SupplierProductMappings { get; set; } = new List<SupplierProductMapping>();

    public virtual ICollection<SupplierStatusShippingCodeCrossRef> SupplierStatusShippingCodeCrossRefs { get; set; } = new List<SupplierStatusShippingCodeCrossRef>();

    public virtual ICollection<TblAlbum> TblAlbums { get; set; } = new List<TblAlbum>();

    public virtual ICollection<TblBatchTransmissionsOrderPart> TblBatchTransmissionsOrderParts { get; set; } = new List<TblBatchTransmissionsOrderPart>();

    public virtual ICollection<TblLayout> TblLayouts { get; set; } = new List<TblLayout>();

    public virtual ICollection<TblOrderInvoice> TblOrderInvoices { get; set; } = new List<TblOrderInvoice>();

    public virtual ICollection<TblOrderLineStatus> TblOrderLineStatuses { get; set; } = new List<TblOrderLineStatus>();

    public virtual ICollection<TblOrderPart> TblOrderParts { get; set; } = new List<TblOrderPart>();

    public virtual ICollection<TblProduct> TblProductProSampleSuppliers { get; set; } = new List<TblProduct>();

    public virtual ICollection<TblProduct> TblProductSupSuppliers { get; set; } = new List<TblProduct>();

    public virtual ICollection<TblStoreSupplierRetailDiscount> TblStoreSupplierRetailDiscounts { get; set; } = new List<TblStoreSupplierRetailDiscount>();

    public virtual ICollection<TblStoreSupplier> TblStoreSuppliers { get; set; } = new List<TblStoreSupplier>();

    public virtual ICollection<TblStoreSuppliersIcsmxmlToid> TblStoreSuppliersIcsmxmlToids { get; set; } = new List<TblStoreSuppliersIcsmxmlToid>();

    public virtual ICollection<TblSupplierEnvelope> TblSupplierEnvelopes { get; set; } = new List<TblSupplierEnvelope>();

    public virtual ICollection<TblSupplierInkColor> TblSupplierInkColors { get; set; } = new List<TblSupplierInkColor>();

    public virtual ICollection<TblSupplierPricing> TblSupplierPricings { get; set; } = new List<TblSupplierPricing>();

    public virtual ICollection<TblSupplierProductsStockOrdered> TblSupplierProductsStockOrdereds { get; set; } = new List<TblSupplierProductsStockOrdered>();

    public virtual ICollection<TblSupplierProductsStock> TblSupplierProductsStocks { get; set; } = new List<TblSupplierProductsStock>();

    public virtual ICollection<TblSupplierStockBatch> TblSupplierStockBatches { get; set; } = new List<TblSupplierStockBatch>();
}
