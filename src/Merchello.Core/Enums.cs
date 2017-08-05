﻿// <auto-generated/> - StyleCop hack to not enforce enum value commentation in this file.

namespace Merchello.Core
{
    /// <summary>
    /// Types of customers.
    /// </summary>
    public enum CustomerType
    {
        Anonymous,
        Customer
    }

    /// <summary>
    /// Types of addresses
    /// </summary>
    public enum AddressType
    {
        Shipping,
        Billing,
        Custom
    }


    /// <summary>
    /// Types of item caches.
    /// </summary>
    public enum ItemCacheType
    {
        Basket,
        Backoffice,
        Wishlist,
        Checkout,
        Custom
    }

    /// <summary>
    /// Types of line items.
    /// </summary>
    public enum LineItemType
    {
        Product,
        Shipping,
        Tax,
        Discount,
        Adjustment,
        Custom
    }

    /// <summary>
    /// Types of payment methods.
    /// </summary>
    public enum PaymentMethodType
    {
        Cash,
        CreditCard,
        Redirect,
        PurchaseOrder,
        CustomerCredit,
        Custom
    }

    /// <summary>
    /// Types of applied payments.
    /// </summary>
    public enum AppliedPaymentType
    {
        Credit,
        Debit,
        Void,
        Denied,
        Refund
    }

    /// <summary>
    /// Types of entities.
    /// </summary>
    public enum EntityType
    {
        Customer,
        EntityCollection,
        GatewayProvider,
        Invoice,
        ItemCache,
        Order,
        Payment,
        Product,
        ProductOption,
        Shipment,
        Warehouse,
        WarehouseCatalog
    }


    /// <summary>
    /// Types of gateway providers.
    /// </summary>
    public enum GatewayProviderType
    {
        Payment,
        Notification,
        Shipping,
        Taxation
    }

    /// <summary>
    /// Types of products.
    /// </summary>
    public enum ProductType
    {
        Custom
    }

    /// <summary>
    /// Types of type fields that can be customized
    /// </summary>
    public enum CustomTypeFieldType
    {
        Address,
        ItemCache,
        LineItem,
        PaymentMethod,
        Product
    }
}