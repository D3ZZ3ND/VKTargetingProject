using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTargetingProject
{
    public class Account
    {
        /// <summary>
        /// Id.
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Токен.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// Пол.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Ссылка на аватарку.
        /// </summary>
        public Uri Photo { get; set; }

        /// <summary>
        /// Ссылка на аватарку.
        /// </summary>
        public bool? HasMobile { get; set; }
    }
}
