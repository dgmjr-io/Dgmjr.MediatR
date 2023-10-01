/*
 * ICreateHandler.cs
 *
 *   Created: 2022-12-21-10:42:55
 *   Modified: 2022-12-21-10:42:56
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;

namespace Dgmjr.MediatR.Handlers.Abstractions;

public interface ICreateHandler<TCreateCommand, TId, TCreateDto, TDto>
    : IRequestHandler<TCreateCommand, TDto>
    where TId : IComparable, IEquatable<TId>
    where TCreateCommand : ICreateCommand<TId, TCreateDto, TDto> { }
