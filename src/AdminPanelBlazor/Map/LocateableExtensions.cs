﻿// <copyright file="LocateableExtensions.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.AdminPanelBlazor.Map
{
    using MUnique.OpenMU.GameLogic;

    /// <summary>
    /// Extension methods for <see cref="ILocateable"/>.
    /// </summary>
    public static class LocateableExtensions
    {
        /// <summary>
        /// Creates a map object for the given locateable object.
        /// </summary>
        /// <param name="locateable">The locateable object.</param>
        /// <returns>The created map object.</returns>
        public static MapObject CreateMapObject(this ILocateable locateable)
        {
            return new MapObject
            {
                Direction = (locateable as IRotatable)?.Rotation ?? default,
                Id = locateable.Id,
                MapId = locateable.CurrentMap.MapId,
                Name = locateable.ToString(),
                X = locateable.Position.X,
                Y = locateable.Position.Y,
            };
        }
    }
}