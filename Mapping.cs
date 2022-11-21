using AutoMapper;
using KPZ_Lab02.Model;
using KPZ_Lab02_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab02_UI.Base
{
    public class Mapping
    {
        public static IMapper Create()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>();
                cfg.CreateMap<DataViewModel, DataModel>();

                cfg.CreateMap<Student, StudentViewModel>();
                cfg.CreateMap<StudentViewModel, Student>();

                cfg.CreateMap<Teacher, TeacherViewModel>();
                cfg.CreateMap<TeacherViewModel, Teacher>();
            });
            return configuration.CreateMapper();
        }
    }
}
