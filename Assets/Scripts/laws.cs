using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laws : MonoBehaviour
{
	public int nomeric;
	public GameObject LawsGM;
	public GameObject Two;
	public lawsController LC;
	public GameObject evenNumber;
	public GameObject oddNumber;
	public float scaleL = 1f;
	public float massL = 1f;

	private Rigidbody2D myScriptsRigidbody2D;



	void Start()
	{
		myScriptsRigidbody2D = GetComponent<Rigidbody2D>();

		LC = LawsGM.GetComponent<lawsController>();
		LC.SRename = true;
		gameObject.transform.localScale = new Vector3(nomeric, nomeric, 0);
		myScriptsRigidbody2D.mass = nomeric*massL+1;

		if(nomeric%2 != 0)
				{
					gameObject.layer = 9;
					evenNumber.SetActive(false);
					oddNumber.SetActive(true);
					GetComponent<SpriteRenderer>().color = new Color(0.5f,1.0f,0.5f,1.0f);

				}
				else
				{
					gameObject.layer = 8;
					evenNumber.SetActive(true);
					oddNumber.SetActive(false);
					GetComponent<SpriteRenderer>().color = new Color(1.0f,0.5f,0.5f,1.0f);
	
				}
	}

	void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.gameObject.tag == "num" )
		{	
			
			if(nomeric-other.gameObject.GetComponent<laws>().nomeric==3)
			{
				nomeric = other.gameObject.GetComponent<laws>().nomeric + nomeric;
				gameObject.transform.localScale = new Vector3(nomeric,nomeric, 0);
				Destroy(other.gameObject);
				myScriptsRigidbody2D.mass = nomeric*massL+1;
				if(nomeric%2 != 0)
				{

					gameObject.layer = 9;
					evenNumber.SetActive(false);
					oddNumber.SetActive(true);
					GetComponent<SpriteRenderer>().color = new Color(0.5f,1.0f,0.5f,1.0f);

				}
				else
				{
					gameObject.layer = 8;
					evenNumber.SetActive(true);
					oddNumber.SetActive(false);
					GetComponent<SpriteRenderer>().color = new Color(1.0f,0.5f,0.5f,1.0f);
	
				}
			}
			else if(nomeric - other.gameObject.GetComponent<laws>().nomeric==0)
			{
				if( int.Parse(other.gameObject.name) > int.Parse(gameObject.name))
				{
					nomeric = other.gameObject.GetComponent<laws>().nomeric + nomeric;
					gameObject.transform.localScale = new Vector3(nomeric, nomeric, 0);
					myScriptsRigidbody2D.mass = nomeric*massL+1;
					Destroy(other.gameObject);
					if(nomeric%2 != 0)
					{
						gameObject.layer = 9;
						evenNumber.SetActive(false);
						oddNumber.SetActive(true);
						GetComponent<SpriteRenderer>().color = new Color(0.5f,1.0f,0.5f,1.0f);

					}
					else
					{
						gameObject.layer = 8;
						evenNumber.SetActive(true);
						oddNumber.SetActive(false);
						GetComponent<SpriteRenderer>().color = new Color(1.0f,0.5f,0.5f,1.0f);
		
					}
				}
			}
			
			else if(nomeric-other.gameObject.GetComponent<laws>().nomeric==1)
			{
				if(nomeric%2 != 0)
					{
						nomeric = nomeric/2;
						myScriptsRigidbody2D.mass =nomeric*massL+1;
						gameObject.transform.localScale = new Vector3(nomeric, nomeric, 0);
						gameObject.layer = 8;
						evenNumber.SetActive(true);
						oddNumber.SetActive(false);
						GetComponent<SpriteRenderer>().color = new Color(1.0f,0.5f,0.5f,1.0f);
						var Parent = Instantiate(this, Two.transform.position, Quaternion.identity);
						Parent.transform.parent = LawsGM.transform;
						LC.SRename = true;
						nomeric = nomeric+1;
						myScriptsRigidbody2D.mass = nomeric;
						gameObject.transform.localScale = new Vector3(nomeric, nomeric, 0);
						gameObject.layer = 9;
						evenNumber.SetActive(false);
						oddNumber.SetActive(true);
						GetComponent<SpriteRenderer>().color = new Color(0.5f,1.0f,0.5f,1.0f);

					}
					else
					{
						nomeric = nomeric/2;
						myScriptsRigidbody2D.mass = nomeric*massL+1;
						gameObject.transform.localScale = new Vector3(nomeric,nomeric, 0);
						gameObject.layer = 9;
						evenNumber.SetActive(false);
						oddNumber.SetActive(true);
						GetComponent<SpriteRenderer>().color = new Color(0.5f,1.0f,0.5f,1.0f);
						var Parent = Instantiate(this, Two.transform.position, Quaternion.identity);
						Parent.transform.parent = LawsGM.transform;
						LC.SRename = true;

						
		
					}
				
			}
		}
	}
}
