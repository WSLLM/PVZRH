using UnityEngine;

public class BackToAlmanac : MonoBehaviour
{
	public Sprite highLightSprite;

	private Sprite originSprite;

	private Vector3 originPosition;

	private SpriteRenderer r;

	private void Start()
	{
		originPosition = base.transform.position;
		r = GetComponent<SpriteRenderer>();
		originSprite = r.sprite;
	}

	private void OnMouseEnter()
	{
		r.sprite = highLightSprite;
		CursorChange.SetClickCursor();
	}

	private void OnMouseExit()
	{
		base.transform.position = originPosition;
		r.sprite = originSprite;
		CursorChange.SetDefaultCursor();
	}

	private void OnMouseDown()
	{
		GameAPP.PlaySound(29);
		base.transform.position = new Vector3(originPosition.x + 0.02f, originPosition.y - 0.02f);
	}

	private void OnMouseUp()
	{
		CursorChange.SetDefaultCursor();
		base.transform.position = originPosition;
		Object.Destroy(base.transform.parent.gameObject);
		UIMgr.EnterAlmanac();
	}
}
