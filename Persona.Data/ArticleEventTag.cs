using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persona.Data
{
    public class ArticleEventTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Column(Order = 1)]
        public int IdEvent { get; set; }
        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Column(Order = 2)]
        public int IdArticle { get; set; }
        [ForeignKey("IdArticle")]
        public virtual Article Article { get; set; }

        /*
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 3)]*/
       
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

    }
}