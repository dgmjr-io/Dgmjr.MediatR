/*
 * IPatchCommand
 *
 *   Created: 2022-12-21-10:02:09
 *   Modified: 2022-12-21-10:02:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.MediatR.Abstractions;

public interface IPatchCommand<TId, TPatchDto, TDto> : ICommand<TDto>
    where TId : IComparable, IEquatable<TId>
{ }
