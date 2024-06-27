import { sha256 } from 'js-sha256';

function Encrypt(value: string) {
    const hash = sha256.create();
    hash.update(value);

    return hash.hex();
}

export { Encrypt }