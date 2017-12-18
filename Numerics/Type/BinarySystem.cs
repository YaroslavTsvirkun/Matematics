using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Type
{
    /// <summary>
    /// Структура BinarySystem представляет двоичную систему исчесления
    /// </summary>
    public struct BinarySystem<Type>
    {
        /// <summary>
        /// Свойство Binary хранит число в двоичной системе исчисления
        /// </summary>
        public List<Type> Binary { get; set; }

        /// <summary>
        /// Перегрузка метода Equals для сравнения объектов
        /// </summary>
        /// <param name="obj">Объект с которым сравнивают  текущий экземпляр</param>
        /// <returns>Возращает true или false</returns>
        public override Boolean Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Перегрузка операции "равно"
        /// </summary>
        /// <param name="left">Левый операнд</param>
        /// <param name="right">Правый операнд</param>
        /// <returns>Возращает true или false</returns>
        public static Boolean operator ==(BinarySystem<Type> left, BinarySystem<Type> right) => 
            BooleanFunctions<Int32, Int32, Boolean>.Equals(Hash(left), Hash(right));

        /// <summary>
        /// Перегрузка операции "не равно"
        /// </summary>
        /// <param name="left">Левый операнд</param>
        /// <param name="right">Правый операнд</param>
        /// <returns>Возращает true или false</returns>
        public static Boolean operator !=(BinarySystem<Type> left, BinarySystem<Type> right) => 
            BooleanFunctions<Int32, Int32, Boolean>.NotEquals(Hash(left), Hash(right));

        /// <summary>
        /// Перегрузка метода GetHashCode для расчета хэш-кода даного экземпляра
        /// </summary>
        /// <returns>Возращает хэш-код даного экземпляра</returns>
        public override Int32 GetHashCode() => base.GetHashCode();

        private static Int32 Hash(BinarySystem<Type> binary) => binary.Binary.GetHashCode();
    }
}