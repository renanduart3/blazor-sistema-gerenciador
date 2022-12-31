using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciador.Domain
{
	public class Inventory
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;
		[Required]
		[Range(1,100, ErrorMessage = " O tamanho tem que ser maior que 0")]
		public int Quantity { get; set; }
		[Required]
		[Range(0, int.MaxValue, ErrorMessage = " O tamanho tem que ser maior ou igual a 0")]
		public double Price { get; set; }
	}
}
