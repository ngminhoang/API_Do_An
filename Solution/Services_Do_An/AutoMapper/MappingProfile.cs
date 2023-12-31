﻿using AutoMapper;
using Repositories_Do_An.DBcontext_vs_Entities;
using Services_Do_An.DTOModels;

namespace Services_Do_An.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin,AdminModel>();
            CreateMap<AppRate,AppRateModel>();
            CreateMap<Bussiness,BussinessModel>();
            CreateMap<Contract,ContractModel>();
            CreateMap<ContractType,ContractTypeModel>();
            CreateMap<Counting, CountingModel>();
            CreateMap<Customer, CustomerModel>();
            CreateMap<DriverRate, DriverRateModel>();
            CreateMap<Driver, DriverModel>();
            CreateMap<Invoice, InvoiceModel>();
            CreateMap<Message, MessageModel>();
            CreateMap<Notification, NotificationModel>();
            CreateMap<NotifType, NotifTypeModel>();
            CreateMap<OrderItem, OrderItemModel>();
            CreateMap<Order, OrderModel>();
            CreateMap<OrderStatus, OrderStatusModel>();
            CreateMap<OwnedVehicleInfor, OwnedVehicleInforModel>();
            CreateMap<Position, PositionModel>();
            CreateMap<Role, RoleModel>();
            CreateMap<Staff, StaffModel>();
            CreateMap<Status, StatusModel>();
            CreateMap<Vehicle, VehicleModel>();
            CreateMap<Warehouse, WarehouseModel>();
            CreateMap<WishedAcceptedDriverList, WishedAcceptedDriverListModel>();

            CreateMap<AdminModel, Admin>();
            CreateMap<AppRateModel, AppRate>();
            CreateMap<BussinessModel, Bussiness>();
            CreateMap<ContractModel, Contract>();
            CreateMap<ContractTypeModel, ContractType>();
            CreateMap<CountingModel, Counting>();
            CreateMap<CustomerModel, Customer>();
            CreateMap<DriverRateModel, DriverRate>();
            CreateMap<DriverModel, Driver>();
            CreateMap<InvoiceModel, Invoice>();
            CreateMap<MessageModel, Message>();
            CreateMap<NotificationModel, Notification>();
            CreateMap<NotifTypeModel, NotifType>();
            CreateMap<OrderItemModel, OrderItem>();
            CreateMap<OrderModel, Order>();
            CreateMap<OrderStatusModel, OrderStatus>();
            CreateMap<OwnedVehicleInforModel, OwnedVehicleInfor>();
            CreateMap<PositionModel, Position>();
            CreateMap<RoleModel, Role>();
            CreateMap<StaffModel, Staff>();
            CreateMap<StatusModel, Status>();
            CreateMap<VehicleModel, Vehicle>();
            CreateMap<WarehouseModel, Warehouse>();
            CreateMap<WishedAcceptedDriverListModel, WishedAcceptedDriverList>();


            CreateMap<OrderModel1, Order>();
            CreateMap<Order, OrderModel1>();

            CreateMap<ContactionModel, Contaction>();
            CreateMap<Contaction, ContactionModel>();
        }
    }
}
