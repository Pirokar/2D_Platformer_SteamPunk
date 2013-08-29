using UnityEngine;
using System.Collections;

public class win2 : MonoBehaviour {
	public Transform p09;
	public Transform p08;
	public Transform p18;
	public Transform p17;
	public Transform p16;
	public Transform p14;
	public Transform p04;
	public Transform p05;
	public Transform p25;
	public Transform p26;
	public Transform p36;
	public Transform p46;
	public Transform p48;
	public Transform p49;
	public Transform p39;
	public Transform p38;
	public Transform p37;
	public Transform p57;
	public Transform p67;
	public Transform p68;
	public Transform p69;
	public Transform p79;
	public Transform p78;
	public Transform p77;
	public Transform p87;
	public Transform p86;
	public Transform p85;
	public Transform p84;
	public Transform p94;
	public Transform p93;
	public Transform p92;
	public Transform p82;
	public Transform p62;
	public Transform p52;
	public Transform p22;
	public Transform p23;
	public Transform p53;
	public Transform p54;
	public Transform p55;
	public Transform p65;
	public Transform p75;
	public Transform p74;
	public Transform p73;
	public Transform p71;
	public Transform p61;
	public Transform p51;
	public Transform p41;
	public Transform p44;
	public Transform p34;
	public Transform p31;
	public Transform p30;
	public Transform p50;
	public Transform p70;
	public Transform p80;
	public Transform p90;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((p09.rotation==Quaternion.Euler(0,0,0)||p09.rotation==Quaternion.Euler(0,0,180))&&p08.rotation==Quaternion.Euler(0,0,270)&&
			p18.rotation==Quaternion.Euler(0,0,180)&&(p17.rotation==Quaternion.Euler(0,0,0)||p17.rotation==Quaternion.Euler(0,0,180))&&
			p14.rotation==Quaternion.Euler(0,0,0)&&p04.rotation==Quaternion.Euler(0,0,270)&&p05.rotation==Quaternion.Euler(0,0,180)&&
			p25.rotation==Quaternion.Euler (0,0,0)&&p26.rotation==Quaternion.Euler (0,0,180)&&(p36.rotation==Quaternion.Euler (0,0,0)||
			p36.rotation==Quaternion.Euler (0,0,180))&&p46.rotation==Quaternion.Euler (0,0,0)&&(p48.rotation==Quaternion.Euler (0,0,0)||
			p48.rotation==Quaternion.Euler (0,0,180))&&p49.rotation==Quaternion.Euler (0,0,180)&&p39.rotation==Quaternion.Euler (0,0,180)&&
			(p38.rotation==Quaternion.Euler (0,0,0)||p38.rotation==Quaternion.Euler (0,0,180))&&p37.rotation==Quaternion.Euler (0,0,270)&&
			(p57.rotation==Quaternion.Euler (0,0,0)||p57.rotation==Quaternion.Euler (0,0,180))&&p67.rotation==Quaternion.Euler (0,0,0)&&
			(p68.rotation==Quaternion.Euler (0,0,0)||p68.rotation==Quaternion.Euler (0,0,180))&&p69.rotation==Quaternion.Euler (0,0,180)&&
			p79.rotation==Quaternion.Euler (0,0,180)&&(p78.rotation==Quaternion.Euler (0,0,0)||p78.rotation==Quaternion.Euler (0,0,180))&&
			p77.rotation==Quaternion.Euler (0,0,270)&&p87.rotation==Quaternion.Euler (0,0,180)&&(p86.rotation==Quaternion.Euler (0,0,0)||
			p86.rotation==Quaternion.Euler (0,0,180))&&(p85.rotation==Quaternion.Euler (0,0,0)||p85.rotation==Quaternion.Euler (0,0,180))&&
			p84.rotation==Quaternion.Euler (0,0,270)&&p94.rotation==Quaternion.Euler (0,0,180)&&(p93.rotation==Quaternion.Euler (0,0,0)||
			p93.rotation==Quaternion.Euler (0,0,180))&&p92.rotation==Quaternion.Euler (0,0,0)&&(p82.rotation==Quaternion.Euler (0,0,0)||
			p82.rotation==Quaternion.Euler (0,0,180))&&(p62.rotation==Quaternion.Euler (0,0,0)||p62.rotation==Quaternion.Euler (0,0,180))&&
			(p52.rotation==Quaternion.Euler (0,0,0)||p52.rotation==Quaternion.Euler (0,0,180))&&p22.rotation==Quaternion.Euler (0,0,270)&&
			p23.rotation==Quaternion.Euler (0,0,180)&&p53.rotation==Quaternion.Euler (0,0,0)&&(p54.rotation==Quaternion.Euler (0,0,0)||
			p54.rotation==Quaternion.Euler (0,0,180))&&p55.rotation==Quaternion.Euler (0,0,180)&&(p65.rotation==Quaternion.Euler (0,0,0)||
			p65.rotation==Quaternion.Euler (0,0,180))&&p75.rotation==Quaternion.Euler (0,0,180)&&(p74.rotation==Quaternion.Euler (0,0,0)||
			p74.rotation==Quaternion.Euler (0,0,180))&&(p73.rotation==Quaternion.Euler (0,0,0)||p73.rotation==Quaternion.Euler (0,0,180))&&
			p71.rotation==Quaternion.Euler (0,0,0)&&(p61.rotation==Quaternion.Euler (0,0,0)||p61.rotation==Quaternion.Euler (0,0,180))&&
			(p51.rotation==Quaternion.Euler (0,0,0)||p51.rotation==Quaternion.Euler (0,0,180))&&p41.rotation==Quaternion.Euler (0,0,270)&&
			p44.rotation==Quaternion.Euler (0,0,180)&&p34.rotation==Quaternion.Euler (0,0,180)&&(p31.rotation==Quaternion.Euler (0,0,0)||
			p31.rotation==Quaternion.Euler (0,0,180))&&p30.rotation==Quaternion.Euler (0,0,270)&&(p50.rotation==Quaternion.Euler (0,0,0)||
			p50.rotation==Quaternion.Euler (0,0,180))&&(p70.rotation==Quaternion.Euler (0,0,0)||p70.rotation==Quaternion.Euler (0,0,180))&&
			(p80.rotation==Quaternion.Euler (0,0,0)||p80.rotation==Quaternion.Euler (0,0,180))&&p90.rotation==Quaternion.Euler (0,0,180)){
			Debug.Log("win");
		}
	
	}
}
