using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Core.Entities
{
    internal class OpcionsEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int SimpleEntityId { get; set; } // Llave foránea para la entidad SimpleEntity

        public SimpleEntity? SimpleEntity { get; set; } // Relación con SimpleEntity

        public DateTime Created { get; set; } = DateTime.UtcNow; // Campo creado
        public DateTime Modified { get; set; } = DateTime.UtcNow; // Campo modificado
    }
}
