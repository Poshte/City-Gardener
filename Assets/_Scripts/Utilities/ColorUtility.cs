using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class ColorUtility
{
	public static IEnumerator ChangeColor(TextMeshProUGUI text, Color target, float speed)
	{
		var original = text.color;

		var elapsedTime = 0f;
		while (elapsedTime < speed)
		{
			text.color = Color.Lerp(target, original, elapsedTime / speed);
			elapsedTime += Time.unscaledDeltaTime;
			yield return null;
		}

		text.color = original;
	}

	public static IEnumerator Blink(TextMeshProUGUI text, Color target, float duration, int count)
	{
		var original = text.color;
		var blinkDuration = duration / (count * 2);

		for (int i = 0; i < count; i++)
		{
			text.color = target;
			yield return new WaitForSeconds(blinkDuration);

			text.color = original;
			yield return new WaitForSeconds(blinkDuration);
		}

		text.color = original;
	}

	public static IEnumerator ChangeColor(Image image, Color target, float speed)
	{
		var original = image.color;

		var elapsedTime = 0f;
		while (elapsedTime < speed)
		{
			image.color = Color.Lerp(target, original, elapsedTime / speed);
			elapsedTime += Time.unscaledDeltaTime;
			yield return null;
		}

		image.color = original;
	}
}
