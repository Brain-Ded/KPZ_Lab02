using System.Runtime.Serialization;

namespace KPZ_Lab02.Model
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public Dictionary<Subject, List<int>> Grades { get; set; }
        [DataMember]
        public Dictionary<Subject, List<Status>> GradesStatus { get; set; }
        [DataMember]
        public int Group { get; set; }
    }

    [DataContract]
    public enum Subject
    {
        [EnumMember]
        Maths = 0,
        [EnumMember]
        English = 1,
        [EnumMember]
        Programming = 2,
        [EnumMember]
        History = 3,
        [EnumMember]
        Philosophy = 4
    }

    [DataContract]
    public enum Status
    {
        [EnumMember]
        NotSubmitted = 0,
        [EnumMember]
        NotRated = 1,
        [EnumMember]
        Done = 2,
    }
}