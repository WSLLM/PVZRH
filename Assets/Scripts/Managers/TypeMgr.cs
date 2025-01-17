using UnityEngine;

public class TypeMgr : MonoBehaviour
{
	public static bool IsPotatoMine(int theSeedType)
	{
		switch (theSeedType)
		{
		case 4:
		case 1007:
		case 1009:
		case 1010:
		case 1015:
			return true;
		default:
			return false;
		}
	}

	public static bool IsNut(int theSeedType)
	{
		if (IsTallNut(theSeedType))
		{
			return true;
		}
		switch (theSeedType)
		{
		case 3:
		case 255:
		case 903:
		case 905:
		case 1003:
		case 1004:
		case 1006:
		case 1010:
		case 1012:
		case 1013:
		case 1021:
		case 1029:
			return true;
		default:
			return false;
		}
	}

	public static bool IsCaltrop(int theSeedType)
	{
		switch (theSeedType)
		{
		case 17:
		case 906:
		case 1060:
		case 1061:
		case 1062:
		case 1063:
		case 1064:
		case 1074:
		case 1075:
			return true;
		default:
			return false;
		}
	}

	public static bool IsTallNut(int theSeedType)
	{
		switch (theSeedType)
		{
		case 903:
		case 1027:
		case 1028:
		case 1039:
		case 1073:
			return true;
		default:
			return false;
		}
	}

	public static bool IsTangkelp(int theSeedType)
	{
		switch (theSeedType)
		{
		case 15:
		case 1049:
		case 1050:
		case 1051:
		case 1056:
		case 1066:
			return true;
		default:
			return false;
		}
	}
}
