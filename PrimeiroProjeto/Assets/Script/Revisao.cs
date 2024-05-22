using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisao : MonoBehaviour
{

    public float[] valoresSoma;

    public float valorQuad;

    public int[] valoresMedia;

    public int valorRef;

    public int paredeY;
    public int paredeX;
    public int paredeArea;

    public float valorReal;

    public float dinheiro;
    public float dinheiroDolar = 5.16f;

    public string nomePessoa;

    public float preço;

    public float salario;

    public float[] num;

    public float[] num2;

    public float senha;

    public string[] opcao;
    public int op;

    public int valorPar;
     float verificar;

    public int valordiv;
     float verificar2;

    // Start is called before the first frame update
    void Start()
    {
        Somar();
        Cumprimentar();
        Media();
        SucAnt();
        AreaQuad();
        NumReal();
        parede();
        Dinheiro();
        Desconto();
        AumentoSalario();
        igual();
        maior();
        Senha();
        Menu();
        par();
        Div5();
    }


    #region
    public void Somar()
    {
        Debug.Log(valoresSoma[0] + 2);
        Debug.Log(valoresSoma[1] + 3);
        Debug.Log(valoresSoma[2] + 8);
        Debug.Log(valoresSoma[1] + valoresSoma[2]);
    }

    void Cumprimentar()
    {
        Debug.Log("Ola," + nomePessoa);
    }
    void Media()
    {
        Debug.Log((valoresMedia[0] + valoresMedia[1] + valoresMedia[2]) / 3);
    }
    void SucAnt()
    {

        Debug.Log(valorRef - 1);
        Debug.Log(valorRef + 1);
    }
    void AreaQuad()
    {
        Debug.Log(valorQuad * valorQuad);
    }
    void NumReal()
    {
        Debug.Log(valorReal * 2);
        Debug.Log(valorReal / 3);
    }
    void parede()
    {
        paredeArea = paredeX * paredeY;
        Debug.Log(paredeArea);
        Debug.Log(paredeArea / 2);
    }
    void Dinheiro()
    {
        Debug.Log(dinheiro / dinheiroDolar + " Dolares");
    }
    void Desconto()
    {
        Debug.Log(preço * 0.95f);
    }
    void AumentoSalario()
    {
        Debug.Log(salario * 1.15f);
    }
    void igual()
    {
        if (num[0] == num[1])
        {
            Debug.Log("Sao Iguais");
        }
        else
        {
            Debug.Log("Sao Diferentes");
        }
    }
    void maior()
    {
        if (num2[0] >= num[1])
        {
            Debug.Log(num2[0]);
        }
        else
        {
            Debug.Log(num2[1]);
        }
    }
    void Senha()
    {
        if (senha == 1234)
        {
            Debug.Log("ACESSO PERMITIDO");
        }
        else
        {
            Debug.Log("ACESSO NEGADO");
        }

    }

    
    void Menu()
    {
        Debug.Log(opcao[0]);
        Debug.Log(opcao[1]);
        Debug.Log(opcao[2]);
        Debug.Log(opcao[3]);
        switch (op)
        {
            case 1:
                Debug.Log(opcao[0] + " R$ 20,00");



                break;
            case 2:
                Debug.Log(opcao[1] + " R$ 56,00");

                break;
            case 3:
                Debug.Log(opcao[2] + " R$ 35,00");

                break;
            case 4:
                Debug.Log(opcao[2] + " R$ 40,00");



                break;

                default:
                Debug.Log("Opcao nao existe");
                break;

        }

    }
    #endregion
    void par()
    {
        verificar = valorPar%2;
        if (verificar == 0)
        {
            Debug.Log("O valor é Par");
        }else
        {
            Debug.Log("O valor é Impar");
        }
    }
    void Div5()
    {
        verificar2 = valordiv % 5;
        if (verificar == 0)
        {
            Debug.Log("O valor é divisel por 5");
        }
        else
        {
            Debug.Log("O valor é indivisivel por 5");
        }
    }

}
