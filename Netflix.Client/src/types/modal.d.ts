export {}

declare global {
    export type ModalBaseOptions = {
        isShow: boolean,
        component: any,
        props?: { [key: string]: any }
        events?: { [key: string]: Function }
    }
}