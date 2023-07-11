using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment {get; set;}
        public string Title {get; set;}
         public string Content {get; set;}
        public int Likes {get; set;}
        public List<Comment> Comments {get; set;} = new List<Comment>();



        public Post(){

        }

        public Post(DateTime moment, string title, string content, int like){

            Moment = moment;
            Title = title;
            Content = content;
            Likes = like;

        }

        public void AddComment(Comment comment){
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment){
            Comments.Remove(comment);
        }

        public override string ToString()//como temos muito comentarios se gerarmos da forma que estavamos fazendo nosso programa perde eficiencia, vamos usar o StringBuilder
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Liker - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments){
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
    
}