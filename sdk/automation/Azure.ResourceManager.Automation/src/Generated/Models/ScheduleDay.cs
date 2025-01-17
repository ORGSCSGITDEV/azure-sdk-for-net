// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Day of the occurrence. Must be one of monday, tuesday, wednesday, thursday, friday, saturday, sunday. </summary>
    public readonly partial struct ScheduleDay : IEquatable<ScheduleDay>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduleDay"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduleDay(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";
        private const string SundayValue = "Sunday";

        /// <summary> Monday. </summary>
        public static ScheduleDay Monday { get; } = new ScheduleDay(MondayValue);
        /// <summary> Tuesday. </summary>
        public static ScheduleDay Tuesday { get; } = new ScheduleDay(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static ScheduleDay Wednesday { get; } = new ScheduleDay(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static ScheduleDay Thursday { get; } = new ScheduleDay(ThursdayValue);
        /// <summary> Friday. </summary>
        public static ScheduleDay Friday { get; } = new ScheduleDay(FridayValue);
        /// <summary> Saturday. </summary>
        public static ScheduleDay Saturday { get; } = new ScheduleDay(SaturdayValue);
        /// <summary> Sunday. </summary>
        public static ScheduleDay Sunday { get; } = new ScheduleDay(SundayValue);
        /// <summary> Determines if two <see cref="ScheduleDay"/> values are the same. </summary>
        public static bool operator ==(ScheduleDay left, ScheduleDay right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduleDay"/> values are not the same. </summary>
        public static bool operator !=(ScheduleDay left, ScheduleDay right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduleDay"/>. </summary>
        public static implicit operator ScheduleDay(string value) => new ScheduleDay(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduleDay other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduleDay other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
