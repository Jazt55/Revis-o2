using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisao : MonoBehaviour
{
    [Header("1")]
    public float[] valoresSoma;
    [Header("2")]
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

    public string nomeAluno;
    public float[] notasAluno;
    public float mediaAluno;

    public float Econsumida;
    public int codigo;

    public float[] triLados;


    public string nomePaciente;
    public float pesoPaciente;
    public float AlturaPaciente;
    public float IMC;

    public string di;

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
        TesteAluno();
        consumoE();
        Triangulo();
        paciente();
        sCase();
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
    
    void par()
    {
        verificar = valorPar % 2;
        if (verificar == 0)
        {
            Debug.Log("O valor é Par");
        }
        else
        {
            Debug.Log("O valor é Impar");
        }
    }
    void Div5()
    {
        verificar2 = valordiv % 5;
        if (verificar2 == 0)
        {
            Debug.Log("O valor é divisel por 5");
        }
        else
        {
            Debug.Log("O valor é indivisivel por 5");
        }
    }
    void TesteAluno()
    {
        mediaAluno = (notasAluno[0] + notasAluno[1] + notasAluno[2]) / 3;

        Debug.Log(mediaAluno);
        if (mediaAluno >= 6)
        {
            Debug.Log(nomeAluno + " Está aprovado");
        }
        else if (mediaAluno >= 4)
        {
            Debug.Log(nomeAluno + " Está de recuperação");
        }
        else
        {
            Debug.Log(nomeAluno + " Está reprovado");

        }

    }
    void consumoE()
    {
        switch (codigo)
        {
            case 1:
                Debug.Log("Devera ser Pago: " + Econsumida * 1.3);
                break;
            case 2:
                Debug.Log("Devera ser Pago: " + Econsumida * 2.2);
                break;
            case 3:
                Debug.Log("Devera ser Pago: " + Econsumida * 3.1);
                break;
        }


    }
    #endregion
    void Triangulo()
    {
        if (triLados[0] == triLados[1] && triLados[0] == triLados[2])
        {
            Debug.Log("O triangulo é equilaterp");
            
            
        }
        else if (triLados[0] == triLados[1] || triLados[0] == triLados[2] || triLados[1] == triLados[2])
        {
            print("O triangulo é iscoceles");
        }
        else
        {
            print("O triangulo é escaleno");
        }
    }
    void paciente()
    {
        IMC = pesoPaciente / (AlturaPaciente * AlturaPaciente);
        print(IMC);
        if(IMC <= 20)
        {
            print(nomePaciente + " Está abaixo do peso ");
        }else if(IMC <= 25)
        {
            print(nomePaciente + " Está normal");
        }else if(IMC <= 30)
        {
            print(nomePaciente + " Está com excesso de peso");
        }
        else if (IMC <= 35)
        {
            print(nomePaciente + " Está com obesidade");
        }
        else
        {
            print(nomePaciente + " Está com obesidade mórbida");
        }

    }
    public int quantcomprada;
    void sCase()
    {
        switch (di) 
        {
            case "ABCD":
                print(quantcomprada * 5.3);
                break;
            case "XYPK":
                print(quantcomprada * 6);
                break;
            case "KLMP":
                print(quantcomprada * 3.2);
                break;
            case "QRST":
                print(quantcomprada * 2.5);
                break;
        

        }

    }

}
   
