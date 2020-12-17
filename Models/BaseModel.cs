using System.Runtime.Serialization;

namespace toDosMvc.Models
{
    public abstract class BaseModel
    {
        [DataMember]
        public int Id {get; protected set;}
    }
}