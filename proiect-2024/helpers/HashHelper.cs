/**************************************************************************
 *                                                                        *
 *  File:        HashHelper.cs                                            *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Acest helper foloseste la criptarea parolelor            *
 *              utilizatorilor pentru a spori securitatea aplicatiei.     *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.hash
{
    /// <summary>
    /// Clasa statica pentru criptarea parolelor utilizatorilor.
    /// </summary>
    /// <remarks>
    /// Aceasta clasa contine o metoda statica pentru a genera un hash SHA-256
    /// pentru o parola data.
    /// </remarks>
    public static class HashHelper
    {
        /// <summary>
        /// Genereaza un hash SHA-256 pentru textul dat.
        /// </summary>
        /// <param name="text">Textul care trebuie criptat.</param>
        /// <returns>Hash-ul SHA-256 al textului.</returns>
        /// <remarks>
        /// Aceasta metoda foloseste algoritmul SHA-256 pentru a cripta textul
        /// si returneaza hash-ul sub forma de sir hexazecimal.
        /// </remarks>
        public static string GetSHA256hash(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
