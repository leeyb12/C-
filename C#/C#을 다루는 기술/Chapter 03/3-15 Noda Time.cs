// Noda Time에서 발췌한 ToInstant 확장 메서드. DateTimeOffset을 대상으로 함

using System;

namespace NodaTime.Extensions
{
    public static class DateTimeOffsetExtensions
    {
        public static Instant ToInstant(this DateTimeOffset dateTimeOffset)
        {
            return Instant.FromDateTimeOffset(dateTimeOffset);
        }
    }
}