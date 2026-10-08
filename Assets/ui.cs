using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    [SerializeField] private cryptor cryptor;
    [SerializeField] private TMP_Text textView;

    [SerializeField] private Button decrypt;
    [SerializeField] private Button peel;
    [SerializeField] private Button correct;
    [SerializeField] private Button encrypt;
    [SerializeField] private Button reset;

    private void Start()
    {
        decrypt.onClick.AddListener(() => Show(cryptor.Decrypt()));
        peel.onClick.AddListener(() => Show(cryptor.Peel()));
        correct.onClick.AddListener(() => Show(cryptor.Correct()));
        encrypt.onClick.AddListener(() => Show(cryptor.Encrypt()));
        reset.onClick.AddListener(() => Show(cryptor.Reset()));

        Show(cryptor.getCurrent());
    }

    private void Show(string s) => textView.text = s;
}