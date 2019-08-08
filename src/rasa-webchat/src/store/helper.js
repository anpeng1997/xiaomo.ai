import { Map, List } from 'immutable';

export function getLocalSession(storage, key) {
    // Attempt to get local session from storage
    const cachedSession = storage.getItem(key);
    var session = null;
    if (cachedSession) {
        // Found existing session in storage
        let parsedSession = JSON.parse(cachedSession)
        // Format conversation from array of object to immutable Map for use by messages components
        const formattedConversation = parsedSession.conversation
            ? Object.values(parsedSession.conversation).map(item => Map(item))
            : [];
        // Check if params is undefined
        const formattedParams = parsedSession.params
            ? parsedSession.params
            : {};
        //Create a new session to return
        session = {
            ...parsedSession,
            conversation: formattedConversation,
            params: formattedParams
        }
    }
    // Returns a formatted session object if any found, otherwise return undefined
    return session;
}


export const storeMessageTo = (storage) => (conversation) => {
    // Store a conversation List to storage
    const localSession = getLocalSession(storage, SESSION_NAME);
    const newSession = {
        // Since immutable List is not a native JS object, store conversation as array
        ...localSession,
        conversation: [...Array.from(conversation)]
    }
    storage.setItem(SESSION_NAME, JSON.stringify(newSession));
    return conversation
}