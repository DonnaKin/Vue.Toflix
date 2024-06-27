import CryptoJS from 'crypto-js'
import { reactive, ref } from 'vue';

const key = ref<string>('jr2F1latBUKpHImrToAtwQxW81Ip8TAk');
const iv = reactive<CryptoJS.lib.WordArray>(CryptoJS.enc.Hex.parse('000000000000000000000000'));

export function Encrypt(txt: string) {
    return CryptoJS.AES.encrypt(txt, CryptoJS.enc.Utf8.parse(key.value), {
        iv: CryptoJS.enc.Hex.parse(iv.toString()),
        mode: CryptoJS.mode.ECB,
        padding: CryptoJS.pad.Pkcs7
    }).toString();
}

export function Decrypt(txt: string) {
    return CryptoJS.AES.decrypt(txt, CryptoJS.enc.Utf8.parse(key.value), {
        iv: CryptoJS.enc.Hex.parse(iv.toString()),
        mode: CryptoJS.mode.ECB,
        padding: CryptoJS.pad.Pkcs7
    }).toString(CryptoJS.enc.Utf8);
}