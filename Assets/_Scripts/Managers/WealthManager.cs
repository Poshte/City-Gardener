using TMPro;
using UnityEngine;

public class WealthManager : MonoBehaviour
{
	private float wealth = 1500f;
	[SerializeField] private TextMeshProUGUI wealthAmount;

	private void Start()
	{
		UpdateWealthUI();
	}

	public void AddWealth(float amount)
	{
		wealth += amount;
		UpdateWealthUI();
	}

	public bool SpendWealth(float amount)
	{
		if (wealth < amount)
		{
			Debug.Log("Not enough money");
			return false;
		}

		wealth -= amount;
		UpdateWealthUI();
		return true;
	}

	private void UpdateWealthUI()
	{
		wealthAmount.text = wealth.ToString();
	}
}
