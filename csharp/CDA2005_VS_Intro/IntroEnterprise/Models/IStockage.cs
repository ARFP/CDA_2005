using System;
using System.Collections.Generic;
using System.Text;

namespace IntroEnterprise.Models
{
    public interface IStockage
    {

        /// <summary>
        /// Sauvegarde l'objet actuel en base de donnéesC:\MDevoldere\github\CDA_2005\csharp\CDA2005_VS_Intro\IntroEnterprise\IStockage.cs
        /// </summary>
        /// <returns></returns>
        bool Save();
    }
}