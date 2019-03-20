using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MyService.Application.Dtos
{
    [DataContract]
    public class PostDto
    {
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public int BlogId { get; set; }
    }
}
