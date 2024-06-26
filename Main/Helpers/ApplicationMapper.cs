﻿using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;

namespace API.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            #region User
            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<Account, SignUpModerator>().ReverseMap();
            CreateMap<Account, UserRolesVM>().ReverseMap();

            CreateMap<Account, UserRoles>().ReverseMap();
            CreateMap<UserRoles, UserRolesVM>().ReverseMap();

            CreateMap<Tutor, TutorDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();

            CreateMap<Tutor, TutorVM>()
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.Dob))
                .ForMember(dest => dest.Education, opt => opt.MapFrom(src => src.Education))
                .ForMember(dest => dest.TypeOfDegree, opt => opt.MapFrom(src => src.TypeOfDegree))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.CardId))
                .ForMember(dest => dest.HourlyRate, opt => opt.MapFrom(src => src.HourlyRate))
                .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo))
                .ForMember(dest => dest.Headline, opt => opt.MapFrom(src => src.Headline))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Account.FullName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Account.Gender))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Account.PhoneNumber))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Account.Avatar))
                .ReverseMap();

            CreateMap<Account, TutorVM>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))            
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
                .ReverseMap();


            CreateMap<Student,StudentVM>()
                .ForMember(dest => dest.SchoolName, opt => opt.MapFrom(src => src.SchoolName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age))
                .ForMember(dest => dest.IsParent, opt => opt.MapFrom(src => src.IsParent))
                .ReverseMap();

            CreateMap<Account,StudentVM>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
                .ReverseMap();

            CreateMap<Tutor, TutorInterVM>()
                .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.Dob))
                .ForMember(dest => dest.Education, opt => opt.MapFrom(src => src.Education))
                .ForMember(dest => dest.TypeOfDegree, opt => opt.MapFrom(src => src.TypeOfDegree))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.CardId))
                .ForMember(dest => dest.HourlyRate, opt => opt.MapFrom(src => src.HourlyRate))
                .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo))
                .ForMember(dest => dest.Headline, opt => opt.MapFrom(src => src.Headline))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Account.FullName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Account.Gender))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Account.PhoneNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Account.Email))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Account.Avatar))
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId))
                .ReverseMap();

            CreateMap<Complaint, ComplaintDTO>().ReverseMap();
            CreateMap<Complaint, ComplaintVM>().ReverseMap();

            #endregion
        }
    }
}
