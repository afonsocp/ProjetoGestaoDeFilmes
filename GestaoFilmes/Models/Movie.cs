using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoFilmes.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório")]
        [Display(Name = "Título")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [Display(Name = "Gênero")]
        public MovieGenre Genre { get; set; }

        [Required(ErrorMessage = "A data de lançamento é obrigatória")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "A duração é obrigatória")]
        [Display(Name = "Duração (minutos)")]
        [Range(1, 999, ErrorMessage = "A duração deve estar entre 1 e 999 minutos")]
        public int Duration { get; set; }

        [Display(Name = "Classificação")]
        public Rating Rating { get; set; }

        [Display(Name = "Sinopse")]
        public string Synopsis { get; set; } = string.Empty;
    }

    public enum MovieGenre
    {
        Ação,
        Aventura,
        Comédia,
        Drama,
        Ficção,
        Terror,
        Documentário,
        Romance
    }

    public enum Rating
    {
        [Display(Name = "Livre")]
        Livre,
        [Display(Name = "10 anos")]
        Dez,
        [Display(Name = "12 anos")]
        Doze,
        [Display(Name = "14 anos")]
        Quatorze,
        [Display(Name = "16 anos")]
        Dezesseis,
        [Display(Name = "18 anos")]
        Dezoito
    }
}