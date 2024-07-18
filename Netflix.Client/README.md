# scraping

## 터미널 열기 단축키
```
Ctrl + J
```

## Project setup - 프로젝트 필요 데이터 설치
### 설치 이 후 package-lock.json(파일), node_modules(폴더) 생성됨
### 라이브러리 추가 및 오류 발생 시 package-lock.json(파일), node_modules(폴더) 삭제 후 'npm install'
```
npm install
```

### Compiles and hot-reloads for development - 프로젝트 실행
```
npm run serve
```

### Compiles and minifies for production - 프로젝트 빌드
```
npm run build
```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).

### 주석
/**********************************************************************************************************/
/*                                             I M P O R T                                                 */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                               D A T A                                                   */
/***********************************************************************************************************/
   

/***********************************************************************************************************/
/*                                            C O M P U T E D                                              */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                              P R O P S                                                  */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                           L I F E C Y C L E                                             */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                             M E T H O D                                                 */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                               E M I T                                                   */
/***********************************************************************************************************/


/***********************************************************************************************************/
/*                                              W A T C H                                                  */
/***********************************************************************************************************/
### 참고 소스
```
<-- <template>
    <div>{{ str1 }}</div>
    <div @click="ChangeObj">Click 시 function 연결</div>
    <div @click="ChangeObjByParam('test')">Click 시 function 연결과 매개변수 사용</div>
    <div @click="emit('emitMethodName', obj1)">emit을 바로 사용 가능</div>
</template> -->

/**********************************************************************************************************/
/*                                             I M P O R T                                                 */
/***********************************************************************************************************/
    import { ref, reactive, computed, toRefs, onMounted, onUnmounted, watch } from 'vue'
	
/***********************************************************************************************************/
/*                                               D A T A                                                   */
/***********************************************************************************************************/
    // ref
        // 1. 기본자료형(원시 타입) 변수 선언 ( import ref 필요 )
            const str1 = ref<string>('기본값을 넣었습니다.')
            const num = ref<number>(0)
            const isTrue = ref<boolean>(false)

        // 2. 기본 자료형(원시 타입) 배열 ( Array<string>'도 가능하지만 reactive<Array<string>> 보다는 reactive<string[]>가 보기 편하기 때문에 통일하도록 하겠습니다. )
            const strArr = ref<string[]>([])

        // 3. ref 값 넣기
            str1.value = '값을 넣습니다.';
            num.value = 2;
            isTrue.value = true;
            strArr.value = [ 'test1', 'test2' ];

        // 4. ref 값 사용하기
            const str2 = ref<string>('기본값을 다르게 넣었습니다.')
            str1.value = str2.value;
            strArr.value.forEach(x => console.log(x));
    

    // reactive
        // 객체 생성 ( 해당 Vue에서만 사용하려면 해당 Vue 파일 내 정의, 공용으로 사용하면 types 폴더에 생성 )
            interface Obj {
                item1 : string,
                item2 : number
            }

        // 1. 객체 변수 선언 ( import reative 필요 )
            const obj1 = reactive<Obj>(Object.create(null));

        // 2. 객체 배열 ( 'Array<객체모델명>'도 가능하지만 reactive<Array<객체모델명>> 보다는 reactive<객체모델명[]>가 보기 편하기 때문에 통일하도록 하겠습니다. )
            const objArr = reactive<Obj[]>([])

        // 3. 객체 변수 값 넣기 ( reactive는 value를 사용하지 않고 객체 내 속성에 바로 접근합니다. )
            obj1.item1 = "obj.item1 타입이 string값이기 때문에 string값을 넣습니다.";
            obj1.item2 = 29;

            const obj2 = reactive<Obj[]>([
                {
                    item1 : 'obj2 item',
                    item2 : 30
                }
            ]);
            
            Object.assign(obj1, obj2); // obj1 = obj2


        // router, store 사용
            // 1. router
                import { useRouter } from 'vue-router'
                const router = useRouter();
            
                function MovePage() {
                    // 1.1 router querystring 얻기
                    let querystring: string = router.currentRoute.value.query.toString();
                    // 1.1 router param 얻기
                    let param: string = router.currentRoute.value.params.from.toString();

                    

                    // 1.2 router 이동
                    router.push({ name : 'login' })
                    router.push({ path : '/' })

                    // 1.3 router param과 함께 이동
                    router.push({ name : 'processing', params: { from: 'confirm' } })
                }

                
        // store 사용
            import { CommonStore } from '@/store';
            const CommonState = CommonStore();
            CommonState.searchText = "store에 searchText에 값을 넣습니다. store 정의가  되지 않았으면 오래가 발생합니다."
    
    /***********************************************************************************************************/
    /*                                            C O M P U T E D                                              */
    /***********************************************************************************************************/
        const numPlusTwo = computed(() => {
            return num.value += 2;
        })
    
    /***********************************************************************************************************/
    /*                                              P R O P S                                                  */
    /***********************************************************************************************************/
        const props = withDefaults(defineProps<{ passObj: Obj }>(), { passObj: Object.create(null) });
        const { passObj } = toRefs(props);
    
    /***********************************************************************************************************/
    /*                                           L I F E C Y C L E                                             */
    /***********************************************************************************************************/
        onMounted(() => {
            str1.value = "컴포넌트가 실행될 때 str1값에 값을 입력하고 싶어서 사용했습니다.";
        })

        onUnmounted(() => {
            str2.value = "컴포넌트가 소멸할 때 str2값에 값을 입력하고 싶어서 사용했습니다.";
        });
    
    /***********************************************************************************************************/
    /*                                             M E T H O D                                                 */
    /***********************************************************************************************************/
        function ChangeObj() {
            obj1.item1 = "ChangeObj가 실행되면 obj1의 item1값을 바꿉니다.";
        }

        function ChangeObjByParam(param: string) {
            obj1.item1 = param;
        }
    
    /***********************************************************************************************************/
    /*                                               E M I T                                                   */
    /***********************************************************************************************************/
        const emit = defineEmits<{ emitMethodName: [PassThisValuetoParent: Obj], emitMethodName2: [PassThisValuetoParent2: Obj] }>();

        function EmitFunc() {
            if (str1.value == "이런 방법으로도 emit할 수 있습니다.") {
                const obj2 = reactive<Obj>({
                    item1 : '새로 변수를 만들어서 전달할려고요',
                    item2 : 1
                })

                emit('emitMethodName', obj2)
            }
            else {
                const obj3 = reactive<Obj>({
                    item1 : 'else이면 obj3을 전달할려고요',
                    item2 : 1
                })
                emit('emitMethodName', obj3)
            }
        }
    
    /***********************************************************************************************************/
    /*                                              W A T C H                                                  */
    /***********************************************************************************************************/
    watch(str1, () => {
        str1.value = 'str1값이 변경되면 현재 위치의 로직이 실행됩니다.';
    })

    watch(obj1, () => {
        obj1.item1 = "{ deep: true }가 없으면 객체가 변견되는 것은 감지하지만 객체 내부 속성이 변경되는 것을 감지할 수 없습니다.";

        obj1.item1 = "obj1의 item1이 변경되었을 때인 객체 내부 항목이 변경되었을 때에도 실행되기를 원한다면 { deep: true }을 추가해주세요";
    }, { deep: true })

    watch(str1, (newVal, oldVal) => {
        str1.value ='newVal, oldVal을 사용하면 str1값이 변경되기 전과 후 값을 얻어 사용할 수 있습니다.';
        str1.value = `str1값이 ${newVal}에서 ${oldVal}로 변경되었습니다.`;
    })
```

### 구조 설명
```
Atoms
    - 이 이상 나눌 수 없는 단위
    - ex 버튼, 텍스트 입력란, 라벨

Molecules
    - Atoms를 여러개 합친 것
    - Organisms 내 들어가는 항목
    - ex 입력폼(라벨 + 입력란), Item vue, header, footer

Organisms
    - 1개의 명확한 기능을 가진 것
    - ex list, Container

Templates
    - 페이지의 틀을 구성하는 것, Organisms 집합체
    - 와이어 프레임

Pages (사용안함 / Views로 대체하거나 필요할 때 생성)
    - 페이지에 컨텐츠가 있는 것, Templates 집합체
    - 디자인 완성 견본
```