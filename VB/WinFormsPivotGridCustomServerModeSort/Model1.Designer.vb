﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("9d001791-bd3f-44e9-b664-480177baa5fe")>
Namespace NWindModel

    #Region "Contexts"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public Partial Class NWindEntities1
        Inherits ObjectContext
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new NWindEntities1 object using the connection string found in the 'NWindEntities1' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=NWindEntities1", "NWindEntities1")
            MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new NWindEntities1 object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "NWindEntities1")
            MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new NWindEntities1 object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "NWindEntities1")
            MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "Partial Methods"
    
        Partial Private Sub OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "ObjectSet Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property SalesPersons() As ObjectSet(Of SalesPerson)
            Get
                If (_SalesPersons Is Nothing) Then
                    _SalesPersons = MyBase.CreateObjectSet(Of SalesPerson)("SalesPersons")
                End If
                Return _SalesPersons
            End Get
        End Property
    
        Private _SalesPersons As ObjectSet(Of SalesPerson)

        #End Region

        #Region "AddTo Methods"
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the SalesPersons EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToSalesPersons(ByVal salesPerson As SalesPerson)
            MyBase.AddObject("SalesPersons", salesPerson)
        End Sub

        #End Region

    End Class

    #End Region

    #Region "Entities"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="NWindModel", Name:="SalesPerson")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class SalesPerson
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new SalesPerson object.
        ''' </summary>
        ''' <param name="orderID">Initial value of the OrderID property.</param>
        ''' <param name="firstName">Initial value of the FirstName property.</param>
        ''' <param name="lastName">Initial value of the LastName property.</param>
        ''' <param name="productName">Initial value of the ProductName property.</param>
        ''' <param name="categoryName">Initial value of the CategoryName property.</param>
        ''' <param name="unitPrice">Initial value of the UnitPrice property.</param>
        ''' <param name="quantity">Initial value of the Quantity property.</param>
        ''' <param name="discount">Initial value of the Discount property.</param>
        ''' <param name="sales_Person">Initial value of the Sales_Person property.</param>
        Public Shared Function CreateSalesPerson(orderID As Global.System.Int32, firstName As Global.System.String, lastName As Global.System.String, productName As Global.System.String, categoryName As Global.System.String, unitPrice As Global.System.Decimal, quantity As Global.System.Int16, discount As Global.System.Single, sales_Person As Global.System.String) As SalesPerson
            Dim salesPerson as SalesPerson = New SalesPerson
            salesPerson.OrderID = orderID
            salesPerson.FirstName = firstName
            salesPerson.LastName = lastName
            salesPerson.ProductName = productName
            salesPerson.CategoryName = categoryName
            salesPerson.UnitPrice = unitPrice
            salesPerson.Quantity = quantity
            salesPerson.Discount = discount
            salesPerson.Sales_Person = sales_Person
            Return salesPerson
        End Function

        #End Region

        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property OrderID() As Global.System.Int32
            Get
                Return _OrderID
            End Get
            Set
                If (_OrderID <> Value) Then
                    OnOrderIDChanging(value)
                    ReportPropertyChanging("OrderID")
                    _OrderID = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("OrderID")
                    OnOrderIDChanged()
                End If
            End Set
        End Property
    
        Private _OrderID As Global.System.Int32
        Private Partial Sub OnOrderIDChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnOrderIDChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Country() As Global.System.String
            Get
                Return _Country
            End Get
            Set
                OnCountryChanging(value)
                ReportPropertyChanging("Country")
                _Country = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Country")
                OnCountryChanged()
            End Set
        End Property
    
        Private _Country As Global.System.String
        Private Partial Sub OnCountryChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCountryChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property FirstName() As Global.System.String
            Get
                Return _FirstName
            End Get
            Set
                If (_FirstName <> Value) Then
                    OnFirstNameChanging(value)
                    ReportPropertyChanging("FirstName")
                    _FirstName = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("FirstName")
                    OnFirstNameChanged()
                End If
            End Set
        End Property
    
        Private _FirstName As Global.System.String
        Private Partial Sub OnFirstNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnFirstNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property LastName() As Global.System.String
            Get
                Return _LastName
            End Get
            Set
                If (_LastName <> Value) Then
                    OnLastNameChanging(value)
                    ReportPropertyChanging("LastName")
                    _LastName = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("LastName")
                    OnLastNameChanged()
                End If
            End Set
        End Property
    
        Private _LastName As Global.System.String
        Private Partial Sub OnLastNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnLastNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ProductName() As Global.System.String
            Get
                Return _ProductName
            End Get
            Set
                If (_ProductName <> Value) Then
                    OnProductNameChanging(value)
                    ReportPropertyChanging("ProductName")
                    _ProductName = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("ProductName")
                    OnProductNameChanged()
                End If
            End Set
        End Property
    
        Private _ProductName As Global.System.String
        Private Partial Sub OnProductNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnProductNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property CategoryName() As Global.System.String
            Get
                Return _CategoryName
            End Get
            Set
                If (_CategoryName <> Value) Then
                    OnCategoryNameChanging(value)
                    ReportPropertyChanging("CategoryName")
                    _CategoryName = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("CategoryName")
                    OnCategoryNameChanged()
                End If
            End Set
        End Property
    
        Private _CategoryName As Global.System.String
        Private Partial Sub OnCategoryNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCategoryNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property OrderDate() As Nullable(Of Global.System.DateTime)
            Get
                Return _OrderDate
            End Get
            Set
                OnOrderDateChanging(value)
                ReportPropertyChanging("OrderDate")
                _OrderDate = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("OrderDate")
                OnOrderDateChanged()
            End Set
        End Property
    
        Private _OrderDate As Nullable(Of Global.System.DateTime)
        Private Partial Sub OnOrderDateChanging(value As Nullable(Of Global.System.DateTime))
        End Sub
    
        Private Partial Sub OnOrderDateChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property UnitPrice() As Global.System.Decimal
            Get
                Return _UnitPrice
            End Get
            Set
                If (_UnitPrice <> Value) Then
                    OnUnitPriceChanging(value)
                    ReportPropertyChanging("UnitPrice")
                    _UnitPrice = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("UnitPrice")
                    OnUnitPriceChanged()
                End If
            End Set
        End Property
    
        Private _UnitPrice As Global.System.Decimal
        Private Partial Sub OnUnitPriceChanging(value As Global.System.Decimal)
        End Sub
    
        Private Partial Sub OnUnitPriceChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Quantity() As Global.System.Int16
            Get
                Return _Quantity
            End Get
            Set
                If (_Quantity <> Value) Then
                    OnQuantityChanging(value)
                    ReportPropertyChanging("Quantity")
                    _Quantity = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Quantity")
                    OnQuantityChanged()
                End If
            End Set
        End Property
    
        Private _Quantity As Global.System.Int16
        Private Partial Sub OnQuantityChanging(value As Global.System.Int16)
        End Sub
    
        Private Partial Sub OnQuantityChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Discount() As Global.System.Single
            Get
                Return _Discount
            End Get
            Set
                If (_Discount <> Value) Then
                    OnDiscountChanging(value)
                    ReportPropertyChanging("Discount")
                    _Discount = StructuralObject.SetValidValue(value)
                    ReportPropertyChanged("Discount")
                    OnDiscountChanged()
                End If
            End Set
        End Property
    
        Private _Discount As Global.System.Single
        Private Partial Sub OnDiscountChanging(value As Global.System.Single)
        End Sub
    
        Private Partial Sub OnDiscountChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Extended_Price() As Nullable(Of Global.System.Decimal)
            Get
                Return _Extended_Price
            End Get
            Set
                OnExtended_PriceChanging(value)
                ReportPropertyChanging("Extended_Price")
                _Extended_Price = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Extended_Price")
                OnExtended_PriceChanged()
            End Set
        End Property
    
        Private _Extended_Price As Nullable(Of Global.System.Decimal)
        Private Partial Sub OnExtended_PriceChanging(value As Nullable(Of Global.System.Decimal))
        End Sub
    
        Private Partial Sub OnExtended_PriceChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property Sales_Person() As Global.System.String
            Get
                Return _Sales_Person
            End Get
            Set
                If (_Sales_Person <> Value) Then
                    OnSales_PersonChanging(value)
                    ReportPropertyChanging("Sales_Person")
                    _Sales_Person = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("Sales_Person")
                    OnSales_PersonChanged()
                End If
            End Set
        End Property
    
        Private _Sales_Person As Global.System.String
        Private Partial Sub OnSales_PersonChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnSales_PersonChanged()
        End Sub

        #End Region

    End Class

    #End Region

    
End Namespace
