/*
 * ICreateCommand.cs
 *
 *   Created: 2022-12-21-09:49:48
 *   Modified: 2022-12-21-09:49:48
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Abstractions;
using System.Net.Http.Headers;

public interface ICreatedNotification<TId, TCreateDto, TDto> : INotification
    where TId : IComparable, IEquatable<TId>
{
    TCreateDto Created { get; set; }
}
