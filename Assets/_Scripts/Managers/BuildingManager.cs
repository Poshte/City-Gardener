using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildingManager : MonoBehaviour
{
	private BuildingTypeSO activeBuildingType;
	private PlayerInput input;
	[SerializeField] private WealthManager wealthManager;

	private void Awake()
	{
		input = new PlayerInput();
	}

	private void Update()
	{
		if (input.PlayerInputs.MouseLeftClick.WasPressedThisFrame())
		{
			if (activeBuildingType == null)
				return;

			if (PayBuildingCost())
				ConstructBuilding();
		}
	}

	private bool PayBuildingCost()
	{
		return wealthManager.SpendWealth(activeBuildingType.Cost);
	}

	private void ConstructBuilding()
	{
		var mousePos = GetMouseWorldPosition();
		Instantiate(activeBuildingType.Prefab, mousePos, Quaternion.identity);
		activeBuildingType = null;
	}

	public void SetActiveBuildingType(BuildingTypeSO buildingType)
	{
		activeBuildingType = buildingType;
	}

	private Vector2 GetMouseWorldPosition()
	{
		var worldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
		worldPos.z = 0f;
		return worldPos;
	}

	private void OnEnable()
	{
		input.PlayerInputs.Enable();
	}

	private void OnDisable()
	{
		input.PlayerInputs.Disable();
	}
}
