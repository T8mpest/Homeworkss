using System.Text;

public class LargeNumber
{
    private StringBuilder value;

    public LargeNumber(string initialValue)
    {
        value = new StringBuilder(initialValue);
    }

    public LargeNumber()
    {
        value = new StringBuilder("0");
    }

    public void Add(LargeNumber other)
    {
        int carry = 0;
        int maxLength = Math.Max(value.Length, other.value.Length);

        for (int i = 0; i < maxLength || carry > 0; i++)
        {
            int digit1 = GetDigit(value, i);
            int digit2 = other.GetDigit(i);
            int sum = digit1 + digit2 + carry;

            carry = sum / 10;
            int resultDigit = sum % 10;

            SetDigit(i, resultDigit);
        }
    }

    public void Subtract(LargeNumber other)
    {
        if (CompareTo(other) < 0)
        {
            throw new InvalidOperationException("Result cannot be negative");
        }

        int borrow = 0;
        int maxLength = Math.Max(value.Length, other.value.Length);

        for (int i = 0; i < maxLength; i++)
        {
            int digit1 = GetDigit(value, i);
            int digit2 = other.GetDigit(i) + borrow;

            if (digit1 < digit2)
            {
                borrow = 1;
                digit1 += 10;
            }
            else
            {
                borrow = 0;
            }

            int resultDigit = digit1 - digit2;
            SetDigit(i, resultDigit);
        }
    }

    public override string ToString()
    {
        return value.ToString();
    }

    private int GetDigit(StringBuilder number, int position)
    {
        if (position < number.Length)
        {
            return number[number.Length - 1 - position] - '0';
        }
        return 0;
    }

    private int GetDigit(int position)
    {
        return GetDigit(value, position);
    }

    private void SetDigit(int position, int digit)
    {
        if (position < value.Length)
        {
            value[value.Length - 1 - position] = (char)(digit + '0');
        }
        else
        {
            value.Insert(0, digit);
        }
    }

    public int CompareTo(LargeNumber other)
    {
        if (value.Length != other.value.Length)
        {
            return value.Length.CompareTo(other.value.Length);
        }

        for (int i = value.Length - 1; i >= 0; i--)
        {
            if (value[i] != other.value[i])
            {
                return value[i].CompareTo(other.value[i]);
            }
        }

        return 0;
    }
}
