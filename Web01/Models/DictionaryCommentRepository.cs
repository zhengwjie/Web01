using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web01.Models
{
    public class DictionaryCommentRepository
    {
        int nextID = 0;
        Dictionary<int, Comment> comments = new Dictionary<int, Comment>();
        public IEnumerable<Comment> GetComment()
        {
            return comments.Values.OrderBy(Comment => Comment.ID);

        }
        public DictionaryCommentRepository(Dictionary<int, Comment> comments)
        {
            this.comments = comments;
        }
        public DictionaryCommentRepository()
        {

        }
        public bool TryGetComment(int id,out Comment comment)
        {
            return comments.TryGetValue(id, out comment);
            
        }
        public Comment AddComment(Comment comment)
        {
            comment.ID = nextID++;
            comments[comment.ID] = comment;
            return comment;
        }
        public bool DeleteComment(int id)
        {
            return comments.Remove(id);
        }
        public bool UpdateComment(Comment comment)
        {
            bool update = comments.ContainsKey(comment.ID);
            if (update)
                comments[comment.ID] = comment;
            return update;
        }
    }
}