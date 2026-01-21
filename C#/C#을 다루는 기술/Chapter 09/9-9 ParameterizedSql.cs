// 안전한 SQL 포매팅 구현

public static class SqlFormattableString
{
    public static SqlCommand NewSqlCommand(
        this SqlConnection conn, FromattableString formattableString)
    {
        SqlParameter[] sqlParameters = formattableString.GetArguments()
            .Select((value, position) =>
                new SqlParameter(Invariant($"@p{position}"), value))
            .ToArray();
        object[] formatArguments = sqlParameters
            .Select(p => new FormatCapturingParameter(p))
            .ToArray();
        string sql = string.Format(formattableString.Format,
            formatArguments);
        var command = new SqlCommand(sql, conn);
        command.Parameters.AddRange(sqlParameters);
        return command;
    }

    private class FormatCapturingParameter : IFormattable
    {
        private readonly SqlParameter parameter;

        internal FormatCapturingParameter(SqlParameter parameter)
        {
            this.parameter = parameter;
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (!string.IsNullOrEmpty(format))
            {
                parameter.SqlDbType = (SqlDbType) Enum.Parse(
                    typeof(SqlDbType), format, true);
            }
            return parameter.ParameterName;
        }
    }
}