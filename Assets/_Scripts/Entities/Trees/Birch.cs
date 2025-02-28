using UnityEngine;

public class Birch : TreeEntity
{
	public override TreeTypes Type { get => TreeTypes.Birch; }
	public override float Cost { get => 200f; }
	public override int PollutionAbsorption { get => 10; }
	public override float GrowthRate { get => 6f; }
	public override float WateringInterval { get => 9f; }
	public override float AbsorptionInterval { get => 6f; }
	public override GrowthStages Stage { get => _stage; set => _stage = value; }
	[SerializeField] private GrowthStages _stage;
	public override SpriteRenderer NeedWaterSprite { get => _needWaterSprite; }
	[SerializeField] private SpriteRenderer _needWaterSprite;

	private Garden garden;

	private void Start()
	{
		garden = gameObject.GetComponentInParent<Garden>();
	}

	public override void Grow()
	{
		base.Grow();
		garden.GrowTree(Type, _stage);
	}
}
