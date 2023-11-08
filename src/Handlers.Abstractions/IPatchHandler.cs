/*
 * IPatchHandler.cs
 *
 *   Created: 2022-12-21-10:47:51
 *   Modified: 2022-12-21-10:48:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Handlers.Abstractions;

public interface IPatchHandler<TPatchCommand, TId, TPatchDto, TDto>
    : IRequestHandler<TPatchCommand, TDto>
    where TPatchCommand : IPatchCommand<TId, TPatchDto, TDto>
    where TId : IComparable, IEquatable<TId>
    where TDto : class
{ }
