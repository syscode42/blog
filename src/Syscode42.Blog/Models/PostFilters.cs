using System.ComponentModel;

namespace Syscode42.Blog.Models
{
    public enum PostFilterEnum
    {
		[Description("Todas Publicações")]
		AllPosts,

		[Description("Em Alta")]
		Trending,

		[Description("Mais Recentes")]
		MostRecents,

		[Description("Mais Antigos")]
		OlderPosts,

		[Description("Mais Curtidos")]
		MostLiked
	}
}
