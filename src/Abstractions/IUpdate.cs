/*
 * IUpdateCommand.cs
 *
 *   Created: 2022-12-21-10:01:45
 *   Modified: 2022-12-21-10:02:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Abstractions;
using Dgmjr.Abstractions;

public interface IUpdateCommand<TModel, TId, TUpdateDto, TDto> : ICommand<TDto>
    where TModel : class, IIdentifiable<TId>
    where TId : IComparable, IEquatable<TId>
{

}
